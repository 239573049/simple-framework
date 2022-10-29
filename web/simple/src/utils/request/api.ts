import instance from "./interceptors";

class Api {
    post(url: string, data: any) {
        return new Promise((resolve, reject) => {
            instance.post(url, data)
                .then((res: any) => {
                    resolve(res)
                })
                .catch((err) => {
                    reject(err)
                })

        })
    }
    post_params(url: string, params: any, data: any) {
        return new Promise((resolve, reject) => {
            instance.post(url, data, { params: params })
                .then(res => {
                    resolve(res)
                })
                .catch((err) => {
                    reject(err)
                })

        })
    }

    put(url: string, data: any) {
        return new Promise((resolve, reject) => {
            instance.put(url, data)
                .then(res => {
                    resolve(res)
                })
                .catch((err) => {
                    reject(err)
                })

        })
    }

    put_params(url: string, params: any, data: any) {
        return new Promise((resolve, reject) => {
            instance.put(url, data, { params: params })
                .then(res => {
                    resolve(res)
                })
                .catch((err) => {
                    reject(err)
                })

        })
    }

    get(url: string, params: any) {
        return new Promise((resolve, reject) => {
            instance.get(url, {
                params: params
            })
                .then(res => {
                    resolve(res)
                })
                .catch((err) => {
                    reject(err)
                })

        })
    }
    del(url: string, params: any) {
        return new Promise((resolve, reject) => {
            instance.delete(url, { params: params })
                .then(res => {
                    resolve(res)
                })
                .catch((err) => {
                    reject(err)
                })

        })
    }
}
export default new Api()