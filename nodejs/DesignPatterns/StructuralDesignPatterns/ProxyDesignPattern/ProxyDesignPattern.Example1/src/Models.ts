export class Video {
  public content?: string;

  constructor(
    public readonly id: string,
    public readonly title: string,
    public readonly isPremium: boolean,
  ) {}
}

export enum SubscriptionType {
  Free = 'Free',
  Premium = 'Premium',
}

export class User {
  constructor(
    public readonly name: string,
    public readonly subscription: SubscriptionType,
  ) {}
}
