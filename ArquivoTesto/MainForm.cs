/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 22/10/2024
 * Time: 21:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArquivoTesto
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
	// Salvar arquivo
	 richTextBox1.SaveFile("teste.txt",RichTextBoxStreamType.PlainText);
	//richTextBox1.SaveFile("teste.rtf");
	MessageBox.Show("Arquivo salvo com sucesso");
	// para poder mudar o aquivo de rtf para txt, precisa fazer o seguinte código:
	//- richTextBox1.SaveFile("teste.txt",RichTextBoxStreamType.PlainText);
	//Sempre lembrar do Plain Text que vai ser usado nessas ocasioes;
		}
		void Button2Click(object sender, EventArgs e)
		{
	// Limpar arquivo
	richTextBox1.LoadFile("teste.txt",RichTextBoxStreamType.PlainText);
	//richTextBox1.LoadFile("teste.rtf");
	
		}
		void Button3Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
		}
	}
}
