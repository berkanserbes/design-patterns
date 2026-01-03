namespace ProxyDesignPattern.ProtectionProxyExample;

/// <summary>
/// Represents user roles in the system.
/// </summary>
public enum Role
{
    Viewer,
    Editor,
    Admin
}

/// <summary>
/// Represents a user with a specific role.
/// </summary>
public class User
{
    public string Name { get; }
    public Role Role { get; }

    public User(string name, Role role)
    {
        Name = name;
        Role = role;
    }
}
