import http from 'k6/http';
import { check, sleep } from 'k6';

export const options = {
  scenarios: {
    constant_arrival: {
      executor: 'constant-arrival-rate',
      rate: 10,                 // Requests per second
      timeUnit: '1s',           // Time unit
      duration: '1m',           
      preAllocatedVUs: 20,      // Initial VUs
      maxVUs: 50,               // Max VUs
    },
  },
};

export default function () {
  const url = 'http://app:80/api/users';
  const response = http.get(url);

  check(response, {
    'status is 200': (r) => r.status === 200,
  });

  sleep(1); // Think time
}
import { textSummary } from 'https://jslib.k6.io/k6-summary/0.0.1/index.js';
export function handleSummary(data) {
    return {
      '/scripts/report_arrival_vus.html': textSummary(data, { format: 'html' }),
    };
  }