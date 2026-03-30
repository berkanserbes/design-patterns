package behavioral.mediator.example1;

public interface IMediator {
    void registerAircraft(Aircraft aircraft);
    void sendMessage(String message, Aircraft sender);
    void requestLanding(Aircraft aircraft);
    void requestTakeoff(Aircraft aircraft);
}
