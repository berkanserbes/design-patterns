package behavioral.mediator.example1;

public class CargoAircraft extends Aircraft {
    public CargoAircraft(IMediator mediator, String callSign) {
        super(mediator, callSign, "Cargo");
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
