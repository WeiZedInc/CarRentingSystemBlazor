import http from 'k6/http';
import { check, sleep } from 'k6';
import { randomIntBetween } from 'k6';

export const options = {
  scenarios: {
    constant_load: {
      executor: 'constant-vus',
      vus: 10,         // Number of virtual users
      duration: '1m', 
    },
  },
};

export default function () {
  const url = 'http://app:80/api/users';
  const response = http.get(url);

  check(response, {
    'status is 200': (r) => r.status === 200,
  });

  sleep(1);
  //sleep(randomIntBetween(1, 5));
}

const { htmlReport } = require('https://raw.githubusercontent.com/benc-uk/k6-reporter/main/dist/bundle.js');

export function handleSummary(data) {
    return {
      '/scripts/report_constant_vus.html': htmlReport(data),
    };
  }
  