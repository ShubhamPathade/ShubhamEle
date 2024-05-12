importScripts("https://www.gstatic.com/firebasejs/7.16.1/firebase-app.js");
importScripts(
    "https://www.gstatic.com/firebasejs/7.16.1/firebase-messaging.js",
);
// For an optimal experience using Cloud Messaging, also add the Firebase SDK for Analytics.
importScripts(
    "https://www.gstatic.com/firebasejs/7.16.1/firebase-analytics.js",
);

// Initialize the Firebase app in the service worker by passing in the
// messagingSenderId.
firebase.initializeApp({
    messagingSenderId: "YOUR-SENDER-ID",
    apiKey: "YOUR_API_KEY",
    projectId: "YOUR_PROJECT_ID",
    appId: "YOUR_APP_ID",
});

// Retrieve an instance of Firebase Messaging so that it can handle background
// messages.
const messaging = firebase.messaging();
var Url = "";

messaging.setBackgroundMessageHandler(function (payload) {
    Url = payload["data"]["url"];
    var Title = payload["data"]["title"];
    var Body = payload["data"]["body"];
    // Customize notification here
    const notificationTitle = Title;
    const notificationOptions = {
        body: Body,
        icon: "https://pbs.twimg.com/profile_images/630410652142534656/KuuD1Llu.jpg",
    };

    return self.registration.showNotification(
        notificationTitle,
        notificationOptions,
    );
});

self.addEventListener('notificationclick', function (event) {
    event.notification.close(); // Android needs explicit close.
    event.waitUntil(
        clients.matchAll({ type: 'window' }).then(windowClients => {
            for (var i = 0; i < windowClients.length; i++) {
                var client = windowClients[i];
                if (client.url === url && 'focus' in client) {
                    return client.focus();
                }
            }
            if (clients.openWindow) {
                return clients.openWindow(Url);
            }
        })
    );
});
