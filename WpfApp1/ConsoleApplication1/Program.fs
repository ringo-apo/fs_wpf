let buttonEventHandler (eventArgs: System.Windows.RoutedEventArgs) =
    let button = eventArgs.Source :?> System.Windows.Controls.Button
    System.Windows.MessageBox.Show(sprintf "%sからのイベントです" button.Name, "イベントハンドラのテスト")
    |> ignore


[<EntryPoint; System.STAThread>]
let main _ =
    let win = new WpfApp1.MainWindow()
    win.Button1.Click
    |> Observable.add buttonEventHandler

    let app = new System.Windows.Application()
    app.Run win
