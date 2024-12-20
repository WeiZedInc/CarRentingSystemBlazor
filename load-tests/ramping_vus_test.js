import http from 'k6/http';
import { check, sleep } from 'k6';

export const options = {
  scenarios: {
    ramping_load: {
      executor: 'ramping-vus',
      startVUs: 0,
      stages: [
        { duration: '30s', target: 20 }, // Ramp-up to 20 VUs
        { duration: '1m', target: 20 },  // Stay at 20 VUs
        { duration: '30s', target: 0 },  // Ramp-down to 0 VUs
      ],
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
      '/scripts/report_ramping_vus.html': htmlReport(data),
    };
  }