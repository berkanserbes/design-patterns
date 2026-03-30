package behavioral.mediator.example1;

public class CommercialAircraft extends Aircraft {
    public CommercialAircraft(IMediator mediator, String callSign) {
        super(mediator, callSign, "Commercial");
    }

    @Override
    public void send(String message) { mediator.sendMessage(message, this); }

    @Override
    public void receive(String message) {
        System.out.println("[" + callSign + "] Received: " + message);
    }

    @Override
    public void requestLanding() { mediator.requestLanding(this); }

    @Override
    public void requestTakeoff() { mediator.requestTakeoff(this); }
}
