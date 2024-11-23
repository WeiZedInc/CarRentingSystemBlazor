import http from 'k6/http';
import { check } from 'k6';
import { sleep } from 'k6';

// Test configuration
export const options = {
    vus: 10, // Number of virtual users
    duration: '30s', // Test duration
};

export default function () {
    const url = 'http://app:80/api/users'; // Use Docker service name and container port
    const response = http.get(url);

    // Validate response
    check(response, {
        'is status 200': (r) => r.status === 200,
    });

    sleep(1); // Simulate user wait time between requests
}
