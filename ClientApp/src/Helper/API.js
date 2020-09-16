import axios from 'axios';

export default class Api {
    constructor() {
        this.client = null;
        this.api_url = 'https://localhost:44383/api';
    }

    init = () => {

        let headers = {
            Accept: "application/json",
        };


        this.client = axios.create({
            baseURL: this.api_url,
            timeout: 31000,
            headers: headers,
        });

        return this.client;
    };

    getData = (path) => {
        return this.init().get(path);
    };

    addNewData = (data,path) => {
        return this.init().post(path, data);
    };
}