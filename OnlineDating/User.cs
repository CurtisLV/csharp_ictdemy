using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineDating;
public enum Sex
{
    Male, Female
}
public enum HairColor
{
    NotSpecified, Blonde, Brown, Black, Redhead
}
public enum EyeColor
{
    NotSpecified = 0,
    Blue = 1,
    Green = 2,
    Brown = 4,
    Black = 8,
    Cyan = 3,
    Browngreen = 6
}
internal class User
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateTime Birthdate { get; private set; }
    public Sex Sex { get; set; }
    public EyeColor EyeColor { get; set; }

    public HairColor HairColor { get; set; }    

    public User(string firstName, string lastName, DateTime birthdate, Sex sex, EyeColor eyeColor, HairColor hairColor)
    {
        FirstName = firstName;
        LastName = lastName;
        Birthdate = birthdate;
        EyeColor = eyeColor;
        HairColor = hairColor;
        Sex = sex;
    }

    public override bool Equals(object? obj)
    {
        return ((obj is User) && (this == (User)obj));
    }

    public override int GetHashCode()
    {
        return FirstName.GetHashCode() ^ LastName.GetHashCode() ^ Birthdate.GetHashCode() ^ Sex.GetHashCode() ^ EyeColor.GetHashCode() ^ HairColor.GetHashCode();
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, {String.Format("YY", Birthdate)}, eyes: {EyeColor}, hair: {HairColor}";
    }

}
