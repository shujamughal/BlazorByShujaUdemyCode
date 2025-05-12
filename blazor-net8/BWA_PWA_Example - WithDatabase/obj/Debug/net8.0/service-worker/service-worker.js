// wwwroot/service-worker.js

const staticCacheName = 'notes-app-static-v1';
const assetsToCache = [
    './',
    './index.html',
    './manifest.webmanifest',
    './css/app.css',
    './_framework/dotnet.js',
    './_framework/blazor.webassembly.js',
    './_framework/blazor.boot.json',
    './_framework/dotnet.native.wasm'
];

// Install event - caching static assets
self.addEventListener('install', (event) => {
    console.log('Service Worker: Installed');
    event.waitUntil(
        caches.open(staticCacheName).then(cache => {
            console.log('Caching app shell');
            return cache.addAll(assetsToCache);
        })
    );
    self.skipWaiting();
});

// Activate event - clears old caches
self.addEventListener('activate', (event) => {
    console.log('Service Worker: Activated');
    event.waitUntil(
        caches.keys().then(cacheNames => {
            return Promise.all(
                cacheNames.map(cache => {
                    if (cache !== staticCacheName) {
                        console.log('Service Worker: Clearing old cache');
                        return caches.delete(cache);
                    }
                })
            );
        })
    );
});

// Fetch event - serves cached content if available
self.addEventListener('fetch', (event) => {
    event.respondWith(
        caches.match(event.request).then(response => {
            return response || fetch(event.request);
        })
    );
});
/* Manifest version: xITuslr9 */
