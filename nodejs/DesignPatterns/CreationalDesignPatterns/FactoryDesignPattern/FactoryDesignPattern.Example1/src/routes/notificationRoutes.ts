import { Router, Request, Response } from 'express';
import { NotificationFactory } from '../factories/NotificationFactory';
import { NotificationRequest } from '../models/NotificationRequest';
import { NotificationType } from '../enums/NotificationType';

const router = Router();
const notificationFactory = new NotificationFactory();

router.post('/', (req: Request, res: Response) => {
  const body = req.body as NotificationRequest;

  if (!body.to || !body.message || !body.notificationType) {
    res.status(400).json({ error: 'to, message and notificationType are required.' });
    return;
  }

  const validTypes = Object.values(NotificationType) as string[];
  if (!validTypes.includes(body.notificationType)) {
    res.status(400).json({ error: `Invalid notificationType. Valid values: ${validTypes.join(', ')}` });
    return;
  }

  const service = notificationFactory.create(body.notificationType);
  const result = service.send(body.to, body.message);

  res.status(200).json({ result });
});

export default router;
