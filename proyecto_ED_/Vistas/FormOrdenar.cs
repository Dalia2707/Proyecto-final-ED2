﻿using proyecto_ED_.EstructurasDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_ED_.Vistas
{
	public partial class FormOrdenar : Form
	{
		int origen;
		public FormOrdenar(int origen)
		{
			InitializeComponent();
			this.origen = origen;
			if (origen == 1)
			{
				//colas
			}
			else if (origen == 2)
			{
				//matriz
			}
			else if (origen == 3)
			{
				//listas
				listaEnlazadaSimple lista = listaEnlazadaSimple.ObtenerInstancia();
				lista.ImprimirLista(dataGridView1);
			}
			else
			{
				//pilas
			}
		}

		private void buttonOrdenarDescendente_Click(object sender, EventArgs e)
		{

			if (origen == 1)
			{
				//colas
			}
			else if (origen == 2)
			{
				//matriz
			}
			else if (origen == 3)
			{
				//listas
				listaEnlazadaSimple lista = listaEnlazadaSimple.ObtenerInstancia();
				lista.OrdenarDecendente();
				lista.ImprimirLista(dataGridView1);
			}
			else
			{
				//pilas
			}
		}

		private void buttonOrdenarAscendente_Click(object sender, EventArgs e)
		{
			if (origen == 1)
			{
				//colas
			}
			else if (origen == 2)
			{
				//matriz
			}
			else if (origen == 3)
			{
				//listas
				listaEnlazadaSimple lista = listaEnlazadaSimple.ObtenerInstancia();
				lista.OrdenarAcendente();
				lista.ImprimirLista(dataGridView1);
			}
			else
			{
				//pilas
			}
		}
	}
}
