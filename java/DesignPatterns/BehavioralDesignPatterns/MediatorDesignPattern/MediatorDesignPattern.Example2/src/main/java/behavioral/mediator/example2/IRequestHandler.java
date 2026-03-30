package behavioral.mediator.example2;

public interface IRequestHandler<T extends IRequest<R>, R> {
    R handle(T request);
}
