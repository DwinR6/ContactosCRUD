﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactosCRUD
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Contactos : ContentPage
	{
		public Contactos ()
		{
			InitializeComponent ();
		}

        private void AddContact_Clicked(object sender, EventArgs e)
        {

        }
    }
}