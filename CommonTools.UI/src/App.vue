<template>
<div>
    <nav class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <router-link class="navbar-brand" to="/">工具箱</router-link>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li><a href="http://www.xdlysk.com">博客</a></li>
                    <li><router-link to="/encryption">加解密</router-link></li>
                    <li><router-link to="/language">语言</router-link></li>
                    <li><router-link to="/codec">编解码</router-link></li>
                    <li><router-link to="/hash">散列/哈希</router-link></li>
                    <li><router-link to="/about">About</router-link></li>
                    <li class="dropdown">
                      <a href="#" class="dropdown-toggle" data-toggle="dropdown">第三方登录<b class="caret"></b>
                      </a>
                      <ul class="dropdown-menu">
                          <li><a v-bind:href="baidu">百度</a></li>
                          <li><a href="#">QQ号</a></li>
                          <li><a href="#">微信</a></li>
                      </ul>
                  </li>
                </ul>
            </div>
        </div>
    </nav>
  <div class="container body-content">
      <router-view/>
  </div>
</div>
</template>

<script>
export default {
  name: "app",
  data(){
    return {
      baidu:`http://openapi.baidu.com/oauth/2.0/authorize?response_type=code&client_id=yL0BwYv21ghRBf1KDfYycIai&redirect_uri=${encodeURIComponent('http://www.xdlysk.com/tools/openaccount?type=baidu&redirect=http://www.xdlysk.com/tools/')}&scope=basic&display=popup`
    }
  }
};
</script>
