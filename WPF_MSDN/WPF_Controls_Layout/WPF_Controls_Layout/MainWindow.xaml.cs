using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Markup;
using System.IO;

namespace WPF_Controls_Layout
{
	/// <summary>
	/// MainWindow.xaml에 대한 상호 작용 논리
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

    public bool RealTimeUpdate = true;

    // Layout이나 Controls의 하나의 아이템이 선택되면 처리하는 함수
    private void HandleSelectionChanged(object sender, SelectionChangedEventArgs args)
    {
      if (sender == null)
        return;

      Details.DataContext = (sender as ListBox).DataContext;
    }

    // XML코드를 보여주는 부분의 Text가 변경되면 동작하는 함수
    protected void HandleTextChanged(object sender, TextChangedEventArgs me)
    {
      if (RealTimeUpdate) ParseCurrentBuffer();
    }

    private void ParseCurrentBuffer()
    {
      try
      {
        var ms = new MemoryStream();
        var sw = new StreamWriter(ms);
        var str = TextBox1.Text;
        sw.Write(str);
        sw.Flush();
        ms.Flush();
        ms.Position = 0;
        try
        {
          // 해당 XML코드를 실제 보이는 UI로 변환
          var content = XamlReader.Load(ms);
          if (content != null)
          {
            // Preview 영역에 할당
            cc.Children.Clear();
            cc.Children.Add((UIElement)content);
          }
          TextBox1.Foreground = Brushes.Black;
          ErrorText.Text = "";
        }

        catch (XamlParseException xpe)
        {
          // 에러 메세지 처리
          TextBox1.Foreground = Brushes.Red;
          TextBox1.TextWrapping = TextWrapping.Wrap;
          ErrorText.Text = xpe.Message;
        }
      }
      catch (Exception)
      {
        // ignored
      }
    }

    // Preview 만 보여주도록 UI를 변환하는 함수
    protected void ShowPreview(object sender, RoutedEventArgs args)
    {
      PreviewRow.Height = new GridLength(1, GridUnitType.Star);
      CodeRow.Height = new GridLength(0);
    }

    // XML코드만 보여주도록 UI를 변환하는 함수
    protected void ShowCode(object sender, RoutedEventArgs args)
    {
      PreviewRow.Height = new GridLength(0);
      CodeRow.Height = new GridLength(1, GridUnitType.Star);
    }

    // Preview와 XML코드 둘다 보여주도록 해주는 함수
    protected void ShowSplit(object sender, RoutedEventArgs args)
    {
      PreviewRow.Height = new GridLength(1, GridUnitType.Star);
      CodeRow.Height = new GridLength(1, GridUnitType.Star);
    }
  }
}
