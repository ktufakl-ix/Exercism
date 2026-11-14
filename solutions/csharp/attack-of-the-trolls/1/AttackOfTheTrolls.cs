// TODO: define the 'AccountType' enum
public enum AccountType
{
    Guest,
    User,
    Moderator
}
// TODO: define the 'Permission' enum
[Flags]
public enum Permission
{
    Read = 0b00000001,
    Write=0b000000010,
    Delete=0b00000100,
    None = 0b00000000,
    All = 0b00000111,
}
static class Permissions
{
    public static Permission Default(AccountType accountType)
    {

        if (accountType == AccountType.Moderator)
            return Permission.Delete | Permission.Read | Permission.Write;
        else if (accountType == AccountType.User)
            return Permission.Write | Permission.Read;
        else if (accountType == AccountType.Guest)
            return Permission.Read;
        else return Permission.None;
    }

    public static Permission Grant(Permission current, Permission grant)
    {
        return current | grant;
    }

    public static Permission Revoke(Permission current, Permission revoke)
    {
        return current & ~revoke;
    }

    public static bool Check(Permission current, Permission check)
    {
        if ((current & check) == check)
        {
            return true;
        }
        else
            return false;
    }
}
