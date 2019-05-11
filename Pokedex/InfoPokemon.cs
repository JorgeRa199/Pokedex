using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Pokedex
{
    [Activity(Label = "InfoPokemon")]
    public class InfoPokemon : Activity, IOnMapReadyCallback
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.InfoPokemon);
            TextView txtNo = FindViewById < TextView >(Resource.Id.txtNumero);
            TextView txtTipo1 = FindViewById<TextView>(Resource.Id.txtTipo1);
            TextView txtTipo2 = FindViewById<TextView>(Resource.Id.txtTipo2);
            TextView txtTotal = FindViewById<TextView>(Resource.Id.txtTotal);
            TextView txtHP = FindViewById<TextView>(Resource.Id.txtHP);
            TextView txtAtaque = FindViewById<TextView>(Resource.Id.txtAtaque);
            TextView txtLegendario = FindViewById<TextView>(Resource.Id.txtLegendario);
            TextView txtVelocidad = FindViewById<TextView>(Resource.Id.txtVelocidad);
            TextView txtDefensaEspecial = FindViewById<TextView>(Resource.Id.txtDefensaEspecial);
            TextView txtAtaqueEspecial = FindViewById<TextView>(Resource.Id.txtAtaqueEspecial);
            TextView txtDefensa = FindViewById<TextView>(Resource.Id.txtDefensa);
            TextView txtNombre = FindViewById<TextView>(Resource.Id.txtNombre);
            
            ImageView imagePokemon = FindViewById<ImageView>(Resource.Id.imagePokemon);

            txtNombre.Text = Intent.GetStringExtra("name");
            txtNo.Text = Intent.GetStringExtra("id");
            txtTipo1.Text = Intent.GetStringExtra("type1");
            txtTipo2.Text = Intent.GetStringExtra("type2");
            txtTotal.Text = Intent.GetStringExtra("total");
            txtHP.Text = Intent.GetStringExtra("hp");
            txtAtaque.Text = Intent.GetStringExtra("attack");
            txtDefensa.Text = Intent.GetStringExtra("defense");
            txtAtaqueEspecial.Text = Intent.GetStringExtra("spAtk");
            txtDefensaEspecial.Text = Intent.GetStringExtra("spDef");
            txtVelocidad.Text = Intent.GetStringExtra("speed");
            txtLegendario.Text = Intent.GetStringExtra("legendary");

            //MANDAR IMAGEN
            var RutaImagen = System.IO.Path.Combine
                                (System.Environment.GetFolderPath
                                (System.Environment.SpecialFolder.Personal), (Intent.GetStringExtra("id") + ".png"));
            var ruta = Android.Net.Uri.Parse(RutaImagen);
            imagePokemon.SetImageURI(ruta);

            var Fragmento = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.fragmentMapa);
            Fragmento.GetMapAsync(this);
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            double latitud = GetRandomDouble(-90, 90);
            double longitud = GetRandomDouble(-180, 180);

            // ARTICUNO ESTA EN LA CIMA DEL MONTE EVEREST
            if (Intent.GetStringExtra("name") == "Articuno")
            {
                latitud = 27.986065;
                longitud = 86.922623;
            }
            else if (Intent.GetStringExtra("name") == "Moltres")
            {
                latitud = 19.01999992;
                longitud = -98.62333084;
            }

            googleMap.MapType = GoogleMap.MapTypeHybrid;
            googleMap.UiSettings.ZoomControlsEnabled = true;
            googleMap.UiSettings.CompassEnabled = true;
            var pivote = CameraPosition.InvokeBuilder();
            pivote.Target(new LatLng(latitud, longitud));
            pivote.Zoom(17);
            pivote.Bearing(0);
            pivote.Tilt(0);
            CameraPosition cameraPosition = pivote.Build();
            CameraUpdate cameraUpdate = CameraUpdateFactory.NewCameraPosition(cameraPosition);
            googleMap.MoveCamera(cameraUpdate);

            MarkerOptions marker = new MarkerOptions();
            marker.SetPosition(new LatLng(latitud, longitud));
            marker.SetTitle(Intent.GetStringExtra("name"));

            var RutaImagen = System.IO.Path.Combine
                                (System.Environment.GetFolderPath
                                (System.Environment.SpecialFolder.Personal), (Intent.GetStringExtra("id") + ".png"));
            marker.SetIcon(BitmapDescriptorFactory.FromPath(RutaImagen));
            googleMap.AddMarker(marker);
        }

        private double GetRandomDouble(double min, double max)
        {
            Random rnd = new Random();
            return rnd.NextDouble() * (max - min) + min;
        }
    }
}