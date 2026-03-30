package behavioral.mediator.example2;

import java.util.*;

public class SimpleMediator {
    @SuppressWarnings("rawtypes")
    private final Map<Class<?>, IRequestHandler> handlers = new HashMap<>();

    @SuppressWarnings("unchecked")
    public <T extends IRequest<R>, R> void register(Class<T> requestType, IRequestHandler<T, R> handler) {
        handlers.put(requestType, handler);
    }

    @SuppressWarnings("unchecked")
    public <R> R send(IRequest<R> request) {
        IRequestHandler handler = handlers.get(request.getClass());
        if (handler == null) throw new IllegalArgumentException("No handler for: " + request.getClass().getSimpleName());
        return (R) handler.handle(request);
    }
}
