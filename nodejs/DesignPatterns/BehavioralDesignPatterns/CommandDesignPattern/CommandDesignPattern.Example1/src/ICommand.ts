/**
 * Command interface — defines execute and unexecute (undo) operations.
 */
export interface ICommand {
  execute(): void;
  unexecute(): void;
}
