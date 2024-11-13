using System;
using ShapeDrawer;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        new Window("Shape Drawer", 800, 600);

        ShapeDrawer.Drawing drawing = new();

        do
        {
            SplashKit.ProcessEvents();
            SplashKit.ClearScreen();

            drawing.Draw();

            if (SplashKit.MouseClicked(MouseButton.LeftButton))
            {
                drawing.AddShape(new ShapeDrawer.Shape());
                Console.WriteLine("Left mouse pressed.");
            }

            if (SplashKit.KeyTyped(KeyCode.SpaceKey))
            {
                drawing.Background = SplashKit.RandomRGBColor(255);
                Console.WriteLine("Space pressed.");
            }

            if (SplashKit.MouseClicked(MouseButton.RightButton))
            {
                drawing.SelectShapesAt(SplashKit.MousePosition());
            }

            if (SplashKit.KeyTyped(KeyCode.DeleteKey) || SplashKit.KeyTyped(KeyCode.BackspaceKey))
            {
                foreach (Shape s in drawing.SelectedShapes)
                {
                    drawing.RemoveShape(s);
                }
            }

            SplashKit.RefreshScreen();
        } while (!SplashKit.WindowCloseRequested("Shape Drawer"));
    }
}
