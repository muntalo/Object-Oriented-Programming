using System;
using ShapeDrawer;
using SplashKitSDK;

public class Program
{
    private enum ShapeKind
    {
        Rectangle, 
        Circle,
        Line
    }

    public static void Main()
    {
        new Window("Shape Drawer", 800, 600);

        ShapeDrawer.Drawing drawing = new();
        ShapeKind kindToAdd = ShapeKind.Circle;
        do
        {
            SplashKit.ProcessEvents();
            SplashKit.ClearScreen();

            drawing.Draw();

            if (SplashKit.KeyDown(KeyCode.RKey))
            {
                kindToAdd = ShapeKind.Rectangle;
                Console.WriteLine("Rectangle selected.");
            }
            if (SplashKit.KeyDown(KeyCode.CKey))
            {
                kindToAdd = ShapeKind.Circle;
                Console.WriteLine("Cirlce selected.");
            }
            if (SplashKit.KeyDown(KeyCode.LKey))
            {
                kindToAdd = ShapeKind.Line;
                Console.WriteLine("Line selected.");
            }

            if (SplashKit.MouseClicked(MouseButton.LeftButton))
            {
                Shape newShape;

                if (kindToAdd == ShapeKind.Circle)
                {
                    MyCircle newCircle = new MyCircle();
                    newShape = newCircle;
                }
                else if (kindToAdd == ShapeKind.Rectangle)
                {
                    MyRectangle newRect = new MyRectangle();
                    newShape = newRect;
                }
                else
                {
                    MyLine newLine = new MyLine();
                    newShape = newLine;
                }

                newShape.X = SplashKit.MouseX();
                newShape.Y = SplashKit.MouseY();
                drawing.AddShape(newShape);

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

            if (SplashKit.KeyTyped(KeyCode.SKey))
            {
                drawing.Save(@"C:\Users\Munty\Desktop\TextDrawing.txt");
            }

            if (SplashKit.KeyTyped(KeyCode.OKey))
            {
                try
                {
                    drawing.Load(@"C:\Users\Munty\Desktop\TextDrawing.txt");
                } catch (Exception e)
                {
                    Console.Error.WriteLine("Error loading file {0}", e.Message);
                }
            }

            SplashKit.RefreshScreen();
        } while (!SplashKit.WindowCloseRequested("Shape Drawer"));
    }
}
