using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firtsName, string lastName)
        {
            FirstName = firtsName;
            LastName = lastName;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FirstName, 3, "Name.Firstname", "Nome deve conter pelo menos 3 caracteres")
                .HasMinLen(LastName, 3, "Name.LastName", "Sobrenome deve conter pelo menos 3 caracteres")
                .HasMaxLen(FirstName, 40, "Name.FirtsName", "Nome deve conter até 40 caracteres")
                .HasMaxLen(LastName, 40, "Name.LastName", "Sobrenome deve conter até 40 caracteres")                
            );
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}