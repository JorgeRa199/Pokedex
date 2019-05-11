using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Json;
using System.Threading.Tasks;
using System.Net;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.IO;
using Android.Content;

namespace Pokedex
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        List<Button> buttons = new List<Button>();
        List<Pokemon> pokemons = new List<Pokemon>();

        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            var btn1 = FindViewById<Button>(Resource.Id.button1);
            ImageView img1 = FindViewById<ImageView>(Resource.Id.imageView1);

            //var API = "https://webapisegundoparcialmoviles.azurewebsites.net/api/values/getallpokemons";

            HttpClient client = new HttpClient();
            HttpResponseMessage respuesta = await client.GetAsync("https://webapisegundoparcialmoviles.azurewebsites.net/api/values/getallpokemons");
            JsonSerializer serializer = new JsonSerializer();


            using (var contenido = await respuesta.Content.ReadAsStreamAsync())
            {
                using (var lectura = new StreamReader(contenido))

                {
                    using (var json = new JsonTextReader(lectura))
                    {
                        pokemons = serializer.Deserialize<List<Pokemon>>(json);
                        for (int i = 1; i < 151; i++)
                        {
                            var buttton = FindViewById<Button>(Resources.GetIdentifier("button" + i, "id", this.PackageName));
                            buttons.Add(buttton);
                            buttons[i-1].SetBackgroundResource((Resource.Drawable.bordered));
                            ImageView image = FindViewById<ImageView>(Resources.GetIdentifier("imageView" + i, "id", this.PackageName));
                            buttton.Text = pokemons[i - 1].name;

                        }

                        for (int i = 1; i < 151; i++)
                        {
                            ImageView image = FindViewById<ImageView>(Resources.GetIdentifier("imageView" + i, "id", this.PackageName));
                            await ArchivoImagen(pokemons[i - 1].picture, (pokemons[i - 1].id).ToString());
                            var RutaImagen = System.IO.Path.Combine
                                (System.Environment.GetFolderPath
                                (System.Environment.SpecialFolder.Personal), (pokemons[i - 1].id.ToString() + ".png"));
                            var ruta = Android.Net.Uri.Parse(RutaImagen);
                            image.SetImageURI(ruta);
                        }
                    }
                }
            }

            buttons[0].Click += delegate { OnListItemClick2(0); };
            buttons[1].Click += delegate { OnListItemClick2(1); };
            buttons[2].Click += delegate { OnListItemClick2(2); };
            buttons[3].Click += delegate { OnListItemClick2(3); };
            buttons[4].Click += delegate { OnListItemClick2(4); };
            buttons[5].Click += delegate { OnListItemClick2(5); };
            buttons[6].Click += delegate { OnListItemClick2(6); };
            buttons[7].Click += delegate { OnListItemClick2(7); };
            buttons[8].Click += delegate { OnListItemClick2(8); };
            buttons[9].Click += delegate { OnListItemClick2(9); };
            buttons[10].Click += delegate { OnListItemClick2(10); };
            buttons[11].Click += delegate { OnListItemClick2(11); };
            buttons[12].Click += delegate { OnListItemClick2(12); };
            buttons[13].Click += delegate { OnListItemClick2(13); };
            buttons[14].Click += delegate { OnListItemClick2(14); };
            buttons[15].Click += delegate { OnListItemClick2(15); };
            buttons[16].Click += delegate { OnListItemClick2(16); };
            buttons[17].Click += delegate { OnListItemClick2(17); };
            buttons[18].Click += delegate { OnListItemClick2(18); };
            buttons[19].Click += delegate { OnListItemClick2(19); };
            buttons[20].Click += delegate { OnListItemClick2(20); };
            buttons[21].Click += delegate { OnListItemClick2(21); };
            buttons[22].Click += delegate { OnListItemClick2(22); };
            buttons[23].Click += delegate { OnListItemClick2(23); };
            buttons[24].Click += delegate { OnListItemClick2(24); };
            buttons[25].Click += delegate { OnListItemClick2(25); };
            buttons[26].Click += delegate { OnListItemClick2(26); };
            buttons[27].Click += delegate { OnListItemClick2(27); };
            buttons[28].Click += delegate { OnListItemClick2(28); };
            buttons[29].Click += delegate { OnListItemClick2(29); };
            buttons[30].Click += delegate { OnListItemClick2(30); };
            buttons[31].Click += delegate { OnListItemClick2(31); };
            buttons[32].Click += delegate { OnListItemClick2(32); };
            buttons[33].Click += delegate { OnListItemClick2(33); };
            buttons[34].Click += delegate { OnListItemClick2(34); };
            buttons[35].Click += delegate { OnListItemClick2(35); };
            buttons[36].Click += delegate { OnListItemClick2(36); };
            buttons[37].Click += delegate { OnListItemClick2(37); };
            buttons[38].Click += delegate { OnListItemClick2(38); };
            buttons[39].Click += delegate { OnListItemClick2(39); };
            buttons[40].Click += delegate { OnListItemClick2(40); };
            buttons[41].Click += delegate { OnListItemClick2(41); };
            buttons[42].Click += delegate { OnListItemClick2(42); };
            buttons[43].Click += delegate { OnListItemClick2(43); };
            buttons[44].Click += delegate { OnListItemClick2(44); };
            buttons[45].Click += delegate { OnListItemClick2(45); };
            buttons[46].Click += delegate { OnListItemClick2(46); };
            buttons[47].Click += delegate { OnListItemClick2(47); };
            buttons[48].Click += delegate { OnListItemClick2(48); };
            buttons[49].Click += delegate { OnListItemClick2(49); };
            buttons[50].Click += delegate { OnListItemClick2(50); };
            buttons[51].Click += delegate { OnListItemClick2(51); };
            buttons[52].Click += delegate { OnListItemClick2(52); };
            buttons[53].Click += delegate { OnListItemClick2(53); };
            buttons[54].Click += delegate { OnListItemClick2(54); };
            buttons[55].Click += delegate { OnListItemClick2(55); };
            buttons[56].Click += delegate { OnListItemClick2(56); };
            buttons[57].Click += delegate { OnListItemClick2(57); };
            buttons[58].Click += delegate { OnListItemClick2(58); };
            buttons[59].Click += delegate { OnListItemClick2(59); };
            buttons[60].Click += delegate { OnListItemClick2(60); };
            buttons[61].Click += delegate { OnListItemClick2(61); };
            buttons[62].Click += delegate { OnListItemClick2(62); };
            buttons[63].Click += delegate { OnListItemClick2(63); };
            buttons[64].Click += delegate { OnListItemClick2(64); };
            buttons[65].Click += delegate { OnListItemClick2(65); };
            buttons[66].Click += delegate { OnListItemClick2(66); };
            buttons[67].Click += delegate { OnListItemClick2(67); };
            buttons[68].Click += delegate { OnListItemClick2(68); };
            buttons[69].Click += delegate { OnListItemClick2(69); };
            buttons[70].Click += delegate { OnListItemClick2(70); };
            buttons[71].Click += delegate { OnListItemClick2(71); };
            buttons[72].Click += delegate { OnListItemClick2(72); };
            buttons[73].Click += delegate { OnListItemClick2(73); };
            buttons[74].Click += delegate { OnListItemClick2(74); };
            buttons[75].Click += delegate { OnListItemClick2(75); };
            buttons[76].Click += delegate { OnListItemClick2(76); };
            buttons[77].Click += delegate { OnListItemClick2(77); };
            buttons[78].Click += delegate { OnListItemClick2(78); };
            buttons[79].Click += delegate { OnListItemClick2(79); };
            buttons[80].Click += delegate { OnListItemClick2(80); };
            buttons[81].Click += delegate { OnListItemClick2(81); };
            buttons[82].Click += delegate { OnListItemClick2(82); };
            buttons[83].Click += delegate { OnListItemClick2(83); };
            buttons[84].Click += delegate { OnListItemClick2(84); };
            buttons[85].Click += delegate { OnListItemClick2(85); };
            buttons[86].Click += delegate { OnListItemClick2(86); };
            buttons[87].Click += delegate { OnListItemClick2(87); };
            buttons[88].Click += delegate { OnListItemClick2(88); };
            buttons[89].Click += delegate { OnListItemClick2(89); };
            buttons[90].Click += delegate { OnListItemClick2(90); };
            buttons[91].Click += delegate { OnListItemClick2(91); };
            buttons[92].Click += delegate { OnListItemClick2(92); };
            buttons[93].Click += delegate { OnListItemClick2(93); };
            buttons[94].Click += delegate { OnListItemClick2(94); };
            buttons[95].Click += delegate { OnListItemClick2(95); };
            buttons[96].Click += delegate { OnListItemClick2(96); };
            buttons[97].Click += delegate { OnListItemClick2(97); };
            buttons[98].Click += delegate { OnListItemClick2(98); };
            buttons[99].Click += delegate { OnListItemClick2(99); };
            buttons[100].Click += delegate { OnListItemClick2(100); };
            buttons[101].Click += delegate { OnListItemClick2(101); };
            buttons[102].Click += delegate { OnListItemClick2(102); };
            buttons[103].Click += delegate { OnListItemClick2(103); };
            buttons[104].Click += delegate { OnListItemClick2(104); };
            buttons[105].Click += delegate { OnListItemClick2(105); };
            buttons[106].Click += delegate { OnListItemClick2(106); };
            buttons[107].Click += delegate { OnListItemClick2(107); };
            buttons[108].Click += delegate { OnListItemClick2(108); };
            buttons[109].Click += delegate { OnListItemClick2(109); };
            buttons[110].Click += delegate { OnListItemClick2(110); };
            buttons[111].Click += delegate { OnListItemClick2(111); };
            buttons[112].Click += delegate { OnListItemClick2(112); };
            buttons[113].Click += delegate { OnListItemClick2(113); };
            buttons[114].Click += delegate { OnListItemClick2(114); };
            buttons[115].Click += delegate { OnListItemClick2(115); };
            buttons[116].Click += delegate { OnListItemClick2(116); };
            buttons[117].Click += delegate { OnListItemClick2(117); };
            buttons[118].Click += delegate { OnListItemClick2(118); };
            buttons[119].Click += delegate { OnListItemClick2(119); };
            buttons[120].Click += delegate { OnListItemClick2(120); };
            buttons[121].Click += delegate { OnListItemClick2(121); };
            buttons[122].Click += delegate { OnListItemClick2(122); };
            buttons[123].Click += delegate { OnListItemClick2(123); };
            buttons[124].Click += delegate { OnListItemClick2(124); };
            buttons[125].Click += delegate { OnListItemClick2(125); };
            buttons[126].Click += delegate { OnListItemClick2(126); };
            buttons[127].Click += delegate { OnListItemClick2(127); };
            buttons[128].Click += delegate { OnListItemClick2(128); };
            buttons[129].Click += delegate { OnListItemClick2(129); };
            buttons[130].Click += delegate { OnListItemClick2(130); };
            buttons[131].Click += delegate { OnListItemClick2(131); };
            buttons[132].Click += delegate { OnListItemClick2(132); };
            buttons[133].Click += delegate { OnListItemClick2(133); };
            buttons[134].Click += delegate { OnListItemClick2(134); };
            buttons[135].Click += delegate { OnListItemClick2(135); };
            buttons[136].Click += delegate { OnListItemClick2(136); };
            buttons[137].Click += delegate { OnListItemClick2(137); };
            buttons[138].Click += delegate { OnListItemClick2(138); };
            buttons[139].Click += delegate { OnListItemClick2(139); };
            buttons[140].Click += delegate { OnListItemClick2(140); };
            buttons[141].Click += delegate { OnListItemClick2(141); };
            buttons[142].Click += delegate { OnListItemClick2(142); };
            buttons[143].Click += delegate { OnListItemClick2(143); };
            buttons[144].Click += delegate { OnListItemClick2(144); };
            buttons[145].Click += delegate { OnListItemClick2(145); };
            buttons[146].Click += delegate { OnListItemClick2(146); };
            buttons[147].Click += delegate { OnListItemClick2(147); };
            buttons[148].Click += delegate { OnListItemClick2(148); };
            buttons[149].Click += delegate { OnListItemClick2(149); };      

        }

        async Task ArchivoImagen(string url, string nombre)
        {
            await DescargaImagen($"{url}", nombre);
        }

        public async Task<string> DescargaImagen(string url, string nombre)
        {
            WebClient client = new WebClient();
            string rutaLocal = null;

            try
            {
                byte[] imageData = await client.DownloadDataTaskAsync(url);
                string carpeta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                string nombreArchivo = nombre + ".png";

                rutaLocal = Path.Combine(carpeta, nombreArchivo);

                File.WriteAllBytes(rutaLocal, imageData);

                return rutaLocal;
            }
            catch (System.Exception ex)
            {
                Toast.MakeText(null, ex.Message, ToastLength.Long).Show();
                return rutaLocal;
            }
        }

        public void OnListItemClick2(int id)
        {
            var DatosparaEnviar = pokemons[id];
            var InstanciaDetalle = new Intent(this, typeof(InfoPokemon));
            InstanciaDetalle.PutExtra("id", DatosparaEnviar.id.ToString());
            InstanciaDetalle.PutExtra("name", DatosparaEnviar.name);
            InstanciaDetalle.PutExtra("type1", DatosparaEnviar.type1);
            InstanciaDetalle.PutExtra("type2", DatosparaEnviar.type2);
            InstanciaDetalle.PutExtra("total", DatosparaEnviar.total.ToString());
            InstanciaDetalle.PutExtra("hp", DatosparaEnviar.hp.ToString());
            InstanciaDetalle.PutExtra("attack", DatosparaEnviar.attack.ToString());
            InstanciaDetalle.PutExtra("defense", DatosparaEnviar.defense.ToString());
            InstanciaDetalle.PutExtra("spAtk", DatosparaEnviar.spAtk.ToString());
            InstanciaDetalle.PutExtra("spDef", DatosparaEnviar.spDef.ToString());
            InstanciaDetalle.PutExtra("speed", DatosparaEnviar.speed.ToString());
            InstanciaDetalle.PutExtra("generation", DatosparaEnviar.generation);
            InstanciaDetalle.PutExtra("legendary", DatosparaEnviar.legendary.ToString());
            InstanciaDetalle.PutExtra("picture", DatosparaEnviar.picture);
            StartActivity(InstanciaDetalle);
        }
    }
}