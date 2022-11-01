import { Component, ReactNode } from "react";
import { Link, Outlet } from "react-router-dom";
import { Layout, Nav, Button, Breadcrumb, Skeleton, Avatar, Toast } from '@douyinfe/semi-ui';
import { IconBell, IconHelpCircle, IconBytedanceLogo } from '@douyinfe/semi-icons';
import menuapi from "../../apis/menuapi";
import icon from "../../utils/icon";
import Lottie from "lottie-react";
import logo from "../../static/logo.json";


const { Header, Footer, Sider, Content } = Layout;

class Admin extends Component {

    state = {
        menutree: []
    }

    constructor(props: any) {
        super(props)
        if (!window.sessionStorage.getItem('token')) {

            Toast.error('请先登录账号')
            window.location.href = "/login"
        }
        this.getMenuTree()
    }

    getMenuTree() {
        menuapi.GetMenuTree({ keywords: "" })
            .then((res: any) => {
                console.log(res);
                this.setState({
                    menutree: res.data
                })
            })
    }


    OnMenuClick(value: any) {
        console.log(value);

    }
    render(): ReactNode {
        var { menutree } = this.state

        return (
            <Layout style={{ border: '1px solid var(--semi-color-border)', height: '100%' }}>
                <Sider style={{ backgroundColor: 'var(--semi-color-bg-1)' }}>
                    <Nav
                        defaultSelectedKeys={['Home']}
                        style={{ maxWidth: 220, height: '100%' }}
                    >
                        <Nav.Header
                            logo={<Lottie animationData={logo} loop={true} />}
                            text={'Simple后台管理'} />
                        {menutree.map((x: any) => {
                            if (x.childrens.length) {
                                return <Nav.Sub itemKey={x.itemKey} text={x.text}>
                                    {x.childrens.map((s: any) => {
                                        <Link to={s.path} >
                                            <Nav.Item itemKey={s.itemKey} text={s.text} icon={icon[x.icon]} onClick={() => this.OnMenuClick(s)} />
                                        </Link>
                                    })}
                                </Nav.Sub>
                            } else {
                                return <Link to={x.path} >
                                    <Nav.Item itemKey={x.itemKey} text={x.text} icon={icon[x.icon]} onClick={() => this.OnMenuClick(x)} />
                                </Link>
                            }
                        })}
                        <Nav.Footer collapseButton={true} />

                    </Nav>
                </Sider>
                <Layout>
                    <Header style={{ backgroundColor: 'var(--semi-color-bg-1)' }}>
                        <Nav
                            mode="horizontal"
                            footer={
                                <>
                                    <Button
                                        theme="borderless"
                                        icon={<IconBell size="large" />}
                                        style={{
                                            color: 'var(--semi-color-text-2)',
                                            marginRight: '12px',
                                        }}
                                    />
                                    <Button
                                        theme="borderless"
                                        icon={<IconHelpCircle size="large" />}
                                        style={{
                                            color: 'var(--semi-color-text-2)',
                                            marginRight: '12px',
                                        }}
                                    />
                                    <Avatar color="orange" size="small">
                                        YJ
                                    </Avatar>
                                </>
                            }
                        ></Nav>
                    </Header>
                    <Content
                        style={{
                            padding: '24px',
                            backgroundColor: 'var(--semi-color-bg-0)',
                        }}
                    >
                        <Breadcrumb
                            style={{
                                marginBottom: '24px',
                            }}
                            routes={['首页', '详情页']}
                        />
                        <div
                            style={{
                                borderRadius: '10px',
                                border: '1px solid var(--semi-color-border)',
                                height: '376px',
                                padding: '32px',
                            }}
                        >
                            <Skeleton placeholder={<Skeleton.Paragraph rows={2} />} loading={false}>
                                <Outlet></Outlet>
                            </Skeleton>
                        </div>
                    </Content>
                    <Footer
                        style={{
                            display: 'flex',
                            justifyContent: 'space-between',
                            padding: '20px',
                            color: 'var(--semi-color-text-2)',
                            backgroundColor: 'rgba(var(--semi-grey-0), 1)',
                        }}
                    >
                        <span
                            style={{
                                display: 'flex',
                                alignItems: 'center',
                            }}
                        >
                            <IconBytedanceLogo size="large" style={{ marginRight: '8px' }} />
                            <span>Copyright © 2019 ByteDance. All Rights Reserved. </span>
                        </span>
                        <span>
                            <span style={{ marginRight: '24px' }}>平台客服</span>
                            <span>反馈建议</span>
                        </span>
                    </Footer>





                </Layout>
            </Layout>
        )
    }
}
export default Admin;