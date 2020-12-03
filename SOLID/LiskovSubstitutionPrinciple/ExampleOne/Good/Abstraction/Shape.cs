namespace SOLID.LiskovSubstitutionPrinciple.ExampleOne.Good.Abstraction
{
    public abstract class Shape
    {
        //Diğer bütün classlara kalıtım verecek ortak özellikler buraya yazılır.
        public virtual int Id { get; set; }
    }
}
