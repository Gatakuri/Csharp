namespace Course {
  struct Point {
    public double X, Y;
    public override string ToString() {
      return "(" + X + "," + Y + ")";
    }
  }
}

Point p;
Console.WriteLine(p); // erro: variável não atribuída
p.X = 10;
p.Y = 20;
Console.WriteLine(p);
p = new Point();
Console.WriteLine(p);
