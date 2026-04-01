/**
 * Represents user roles in the system.
 */
export enum Role {
  Viewer = "Viewer",
  Editor = "Editor",
  Admin = "Admin",
}

/**
 * Represents a user with a specific role.
 */
export class User {
  constructor(
    public readonly name: string,
    public readonly role: Role
  ) {}
}
