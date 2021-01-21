using System;


namespace PizzaBox.Domain.Abstracts
{
  public abstract class AEntity
  {
    public long EntityId { get; set;}

    protected AEntity()
    {
      // EntityId = DateTime.Now.Ticks;
    }
  }
}
