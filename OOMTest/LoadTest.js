import http from 'k6/http';

export let options = {
    insecureSkipTLSVerify: true,
    noConnectionReuse: false,
    vus: 10,
    duration: '5m'
};

export default () => {
    http.get('https://localhost:7098/',{
    headers:{
        "Content-Type": "application/json",
        "accept": "text/plain"
    }
});
};