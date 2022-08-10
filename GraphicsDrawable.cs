namespace MauiGraphicsTest;

public class GraphicsDrawable : IDrawable
{
  public void Draw(ICanvas canvas, RectF dirtyRect)
  {
    // Drawing code goes here
    canvas.StrokeColor = Colors.Red;
    canvas.StrokeSize = 6;
    canvas.DrawLine(10, 10, 90, 100);
  }
}
