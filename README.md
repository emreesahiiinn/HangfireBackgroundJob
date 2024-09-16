# Hangfire Background Job Project

This project is a background job processing application developed using .NET 9. The following technologies are utilized:

## Features

- **Hangfire**: Manages background jobs. Jobs can be monitored via the Hangfire Dashboard.
- **Redis**: Used for Hangfire job queue and data caching. The Redis server runs at `localhost:6379`.
- **Prometheus**: Collects metrics for background jobs. Metric data is accessible at [http://localhost:5285/metrics](http://localhost:5285/metrics).

## Configuration

- **Hangfire Dashboard**: Monitor background jobs at [http://localhost:5285/hangfire](http://localhost:5285/hangfire).
- **Prometheus Metrics**: Access metrics at [http://localhost:5285/metrics](http://localhost:5285/metrics).

## Notes

- **Redis Configuration**: Redis is used for Hangfire. Ensure that the Redis server is running and accessible at `localhost:6379`.