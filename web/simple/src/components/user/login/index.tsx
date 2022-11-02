import { Component, ReactNode } from "react";
import { Form, Toast, Button, Card } from '@douyinfe/semi-ui';
import { IconPipixiaLogo } from '@douyinfe/semi-icons';
import './index.css'
import authapi from "../../../apis/authapi";
import { SignOnInput } from "../../../modules/auth/SignOnInput";

export class LoginLayout extends Component {

    constructor(props: any) {
        super(props)
    }

    handleSubmit(value: SignOnInput) {
        authapi.SignOn(value)
            .then((res: any) => {
                Toast.success('登录成功')
                window.sessionStorage.setItem('token', res.data);
                window.location.href = "/"
            })
    }

    render(): ReactNode {
        return (
            <div className="layout" >
                <Card className="login-layout">
                    <h1><IconPipixiaLogo size='extra-large' />Simple 管理系统</h1>
                    <Form onSubmit={(values: any) => this.handleSubmit(values)} style={{ width: 400 }}>

                        {({ formState, values, formApi }) => (
                            <>
                                <Form.Input field='username' label='用户名' style={{ width: '100%' }} placeholder='请输入您的用户名'></Form.Input>
                                <Form.Input field='password' mode="password" label='密码' style={{ width: '100%' }} placeholder='请输入您的密码'></Form.Input>
                                <Form.Checkbox field='agree' noLabel>我已阅读并同意服务条款</Form.Checkbox>
                                <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                                    <p>
                                        <Button theme='borderless' style={{ color: 'var(--semi-color-primary)', marginLeft: 10, cursor: 'pointer' }}>注册</Button>
                                    </p>
                                    <Button disabled={(!values.agree)} htmlType='submit' type="tertiary">登录</Button>
                                </div>
                            </>
                        )}
                    </Form>
                </Card>
            </div>
        )
    }
}

