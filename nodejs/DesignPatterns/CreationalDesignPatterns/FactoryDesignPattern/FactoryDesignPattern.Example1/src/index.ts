import express from 'express';
import notificationRoutes from './routes/notificationRoutes';

const app = express();
const PORT = 3000;

app.use(express.json());

app.use('/api/notification', notificationRoutes);

app.listen(PORT, () => {
  console.log(`Factory Design Pattern - Notification API running on http://localhost:${PORT}`);
  console.log(`POST http://localhost:${PORT}/api/notification`);
  console.log(`Body: { "to": "user@example.com", "message": "Hello", "notificationType": "Email" | "Sms" | "PushNotification" }`);
});
