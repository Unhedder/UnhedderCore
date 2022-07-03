using System.Windows;
using UnhedderCore;

namespace WpfSimpleDemo
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			var panel = new System.Windows.Forms.Panel();
			canvas.Child = panel;
			canvas.Loaded += (s, e) =>
			{
				new Display(panel.Handle);
			};
		}
	}
}
