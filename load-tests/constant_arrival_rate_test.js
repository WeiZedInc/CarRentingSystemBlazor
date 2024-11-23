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

const { htmlReport } = require('https://raw.githubusercontent.com/benc-uk/k6-reporter/main/dist/bundle.js');

export function handleSummary(data) {
    return {
      '/scripts/report_constant_arrival_rate.html': htmlReport(data),
    };
  }