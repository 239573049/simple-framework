import { Component, ReactNode } from "react";
import userinfoapi from "../../../apis/userinfoapi";

const columns = [
    {
        title: '昵称',
        dataIndex: 'Name',
        render: (value: any) => `${value}`,
    },
    {
        title: '账号',
        dataIndex: 'userName',
        render: (value: any) => `${value}`,
    },
    {
        title: '密码',
        dataIndex: 'passWord',
        render: (value: any) => `${value}`,
    },
    {
        title: '头像',
        dataIndex: 'avatar',
        render: (value: any) => `${value}`,
    },
    {
        title: '账号状态',
        dataIndex: 'status',
        render: (value: any) => `${value}`,
    },
]

class User extends Component {



    render(): ReactNode {
        return (<div>
            用户管理
        </div>)
    }
}

export default User;