// wwwroot/service-worker.js

// Basic Service Worker setup - logs installation and activation
self.addEventListener('install', (event) => {
    console.log('Service Worker: Installed');
    self.skipWaiting(); // Activate the service worker immediately after installation
});

self.addEventListener('activate', (event) => {
    console.log('Service Worker: Activated');
});
