using System.Collections.Generic;
using System.Collections.ObjectModel;

// This class represents the authentication system. The important part is that
// the developer list is exposed in a read-only form, so external code cannot
// add, remove, or replace entries in the original collection.
public class Authenticator
{
    // These values are fixed strings, so constants are appropriate.
    // Using constants also avoids accidental typos and makes the code clearer.
    private class EyeColor
    {
        public const string Blue = "blue";
        public const string Green = "green";
        public const string Brown = "brown";
        public const string Hazel = "hazel";
        public const string Grey = "grey";
    }

    // The constructor stores the admin identity once when the object is created.
    // The field is readonly, so it cannot be reassigned later.
    public Authenticator(Identity admin)
    {
        this.admin = admin;
    }

    // The admin identity is stored as a value type, so the public property returns
    // a copy rather than a direct reference to the original data.
    private readonly Identity admin;

    // The developer map is wrapped by ReadOnlyDictionary. This gives callers a
    // dictionary-shaped interface, but the concrete implementation rejects any
    // add/remove/update operation, so the original data cannot be tampered with.
    private IDictionary<string, Identity> developers =
        new ReadOnlyDictionary<string, Identity>(
            new Dictionary<string, Identity>
            {
                ["Bertrand"] = new Identity
                {
                    Email = "bert@ex.ism",
                    EyeColor = "blue"
                },

                ["Anders"] = new Identity
                {
                    Email = "anders@ex.ism",
                    EyeColor = "brown"
                }
            });

    // Returning a copy of the struct prevents callers from modifying the internal
    // admin value through the public property.
    public Identity Admin
    {
        get { return admin; }
    }

    // The public method exposes the developer data through an IDictionary contract.
    // The underlying ReadOnlyDictionary implementation will reject changes,
    // so callers can read the data but cannot modify the collection.
    public IDictionary<string, Identity> GetDevelopers()
    {
        return developers;
    }
}

// Identity is a small data container. It is a struct, which means it is copied
// when passed around, so the Authenticator does not expose a mutable reference
// to the original state.
public struct Identity
{
    public string Email { get; set; }

    public string EyeColor { get; set; }
}
