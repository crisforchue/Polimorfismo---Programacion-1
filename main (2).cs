using System;

public abstract class Perro
{
  public virtual string dormir()
  {
    return "Perro Dormido";
  }
  public abstract string Despertar();
}
public class Bulldog : Perro
{
  public override string dormir()
  {
    return "Bulldog Dormido";
  }
  public override string Despertar()
  {
    return "Bulldog Despertado";
  }
}

public class Rottweiler : Perro
{
  public override string dormir()
  {
    return "Rottweiler Dormido";
  }
  public override string Despertar()
  {
    return "Rottweiler Despertado";
  }
}
public class Program
{
  public static void Main (string[] args)
  {
    Perro perro = new Bulldog();
    Console.WriteLine(perro.dormir()); 

    perro = new Rottweiler();
    Console.WriteLine(perro.dormir());
  }
}