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
    NotSpecified, Blond, Brown, Black, Ginger
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

    public User(string firstName, string lastName, Sex sex, DateTime birthdate, EyeColor eyeColor, HairColor hairColor)
    {
        FirstName = firstName;
        LastName = lastName;
        Birthdate = birthdate;
        EyeColor = eyeColor;
        HairColor = hairColor;
        Sex = sex;
    }

    public override bool Equals(object obj)
    {
        return ((obj is User) && (this == (User)obj));
    }

    public static bool operator ==(User a, User b)
    {
        return (a.FirstName == b.FirstName && a.LastName == b.LastName && a.Birthdate == b.Birthdate && a.EyeColor == b.EyeColor && a.HairColor == b.HairColor);
    }

    public static bool operator !=(User a, User b)
    {
        return !(a == b);
    }

    public override int GetHashCode()
    {
        return FirstName.GetHashCode() ^ LastName.GetHashCode() ^ Birthdate.GetHashCode() ^ Sex.GetHashCode() ^ EyeColor.GetHashCode() ^ HairColor.GetHashCode();
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, {Birthdate.ToString("yyyy")}, eyes: {EyeColor}, hair: {HairColor}";
    }

}
