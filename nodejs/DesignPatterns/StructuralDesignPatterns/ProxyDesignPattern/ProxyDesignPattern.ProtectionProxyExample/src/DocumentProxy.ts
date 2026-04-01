import { IDocument } from "./IDocument";
import { Role, User } from "./User";
import { SensitiveDocument } from "./SensitiveDocument";

/**
 * Protection Proxy - Controls access to the document based on user role.
 *
 * Access Rules:
 * - Viewer: Can only Read
 * - Editor: Can Read and Write
 * - Admin:  Can Read, Write and Delete
 */
export class DocumentProxy implements IDocument {
  constructor(
    private readonly _realDocument: SensitiveDocument,
    private readonly _user: User
  ) {
    console.log(`[Proxy] Access granted to user '${_user.name}' with role '${_user.role}'`);
  }

  read(): void {
    // All roles can read
    console.log(`[Proxy] User '${this._user.name}' is reading...`);
    this._realDocument.read();
  }

  write(content: string): void {
    // Only Editor and Admin can write
    if (this._user.role === Role.Viewer) {
      console.log(`[Proxy] ACCESS DENIED: '${this._user.name}' (Viewer) cannot write!`);
      return;
    }

    console.log(`[Proxy] User '${this._user.name}' is writing...`);
    this._realDocument.write(content);
  }

  delete(): void {
    // Only Admin can delete
    if (this._user.role !== Role.Admin) {
      console.log(`[Proxy] ACCESS DENIED: '${this._user.name}' (${this._user.role}) cannot delete!`);
      return;
    }

    console.log(`[Proxy] User '${this._user.name}' is deleting...`);
    this._realDocument.delete();
  }
}
