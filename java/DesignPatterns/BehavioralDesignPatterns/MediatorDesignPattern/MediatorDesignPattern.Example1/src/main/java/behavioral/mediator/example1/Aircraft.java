package behavioral.mediator.example1;

public abstract class Aircraft {
    protected IMediator mediator;
    protected final String callSign;
    protected final String aircraftType;

    public Aircraft(IMediator mediator, String callSign, String aircraftType) {
        this.mediator = mediator;
        this.callSign = callSign;
        this.aircraftType = aircraftType;
    }

    public String getCallSign() { return callSign; }
    public String getAircraftType() { return aircraftType; }

    public abstract void send(String message);
    public abstract void receive(String message);
    public abstract void requestLanding();
    public abstract void requestTakeoff();
}
