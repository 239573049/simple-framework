import { Component, ReactNode } from "react";
import { Link, Outlet } from "react-router-dom";
import { Layout, Nav, Button, Skeleton, Avatar, Toast, Icon } from '@douyinfe/semi-ui';
import { IconBell, IconHelpCircle } from '@douyinfe/semi-icons';
import menuapi from "../../apis/menuapi";
import Lottie from "lottie-react";
import icon from "../../utils/icon/index";
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

    giteeIcon() {
        return <svg className="icon" viewBox="0 0 1024 1024" version="1.1" xmlns="http://www.w3.org/2000/svg" p-id="1792" width="16" height="16"><path d="M512 1024C229.222 1024 0 794.778 0 512S229.222 0 512 0s512 229.222 512 512-229.222 512-512 512z m259.149-568.883h-290.74a25.293 25.293 0 0 0-25.292 25.293l-0.026 63.206c0 13.952 11.315 25.293 25.267 25.293h177.024c13.978 0 25.293 11.315 25.293 25.267v12.646a75.853 75.853 0 0 1-75.853 75.853h-240.23a25.293 25.293 0 0 1-25.267-25.293V417.203a75.853 75.853 0 0 1 75.827-75.853h353.946a25.293 25.293 0 0 0 25.267-25.292l0.077-63.207a25.293 25.293 0 0 0-25.268-25.293H417.152a189.62 189.62 0 0 0-189.62 189.645V771.15c0 13.977 11.316 25.293 25.294 25.293h372.94a170.65 170.65 0 0 0 170.65-170.65V480.384a25.293 25.293 0 0 0-25.293-25.267z" fill="#C71D23" p-id="1793"></path></svg>
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
                        </span>
                        <span>
                            <a href="https://gitee.com/Simple-china/simple-framework" style={{ marginRight: "5px" }}><Icon svg={this.giteeIcon()} /></a>
                            <a href="https://github.com/239573049/simple-framework">{icon["IconGithubLogo"]}</a>
                        </span>
                    </Footer>





                </Layout>
            </Layout>
        )
    }
}
export default Admin;