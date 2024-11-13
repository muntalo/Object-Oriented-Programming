using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        new Window("Shape Drawer", 800, 600);

        ShapeDrawer.Shape myShape = new();

        do
        {
            SplashKit.ProcessEvents();
            SplashKit.ClearScreen();


            myShape.Draw();

            if (SplashKit.MouseClicked(MouseButton.LeftButton))
            {
                Console.WriteLine(SplashKit.MouseX());
                Console.WriteLine(SplashKit.MouseY());
                myShape.X = SplashKit.MouseX();
                myShape.Y = SplashKit.MouseY();
            }

            if (myShape.IsAt(SplashKit.MousePosition()) && SplashKit.KeyTyped(KeyCode.SpaceKey))
            {
                myShape.Color = SplashKit.RandomRGBColor(255);
            }

            SplashKit.RefreshScreen();

        } while (!SplashKit.WindowCloseRequested("Shape Drawer"));
    }
}
