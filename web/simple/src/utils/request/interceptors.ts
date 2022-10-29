import axios from 'axios';
import { Toast } from '@douyinfe/semi-ui';

const header = {
    'Content-Type': 'application/json;charset=UTF-8',
};
// axios 实例
const instance = axios.create({
    timeout: 60000,
    responseType: 'json',
    baseURL: 'http://localhost',
    headers: header,
});

// 添加请求拦截器
instance.interceptors.request.use(
    (request) => {
        const token = window.sessionStorage.getItem('token');
        request.headers = {
            "Authorization": 'Bearer ' + token!,
        };
        return request;
    },
    (error) => {
        return Promise.reject(error);
    },
);
// 添加响应拦截器
instance.interceptors.response.use(
    (response) => {
        const errorCode = response?.data?.statusCode;
        switch (errorCode) {
            case '401':
                Toast.error('请先登录账号')
                window.location.href = '/';
                break;
            default:
                break;
        }
        return response.data;
    },
    (error) => {
        const response = error.response;
        const data = response.data
        // 根据返回的http状态码做不同的处理
        switch (response?.status) {
            case 400:
                Toast.error(data.message)
                break;
            case 401:
                Toast.error('请先登录账号')
                window.location.href = "/login"
                break;
            case 403:
                Toast.error('没有权限')
                break;
            default:
                Toast.error(data.message)
                break;
        }
        return Promise.reject(response || { message: error.message });
    },
);

export default instance;
