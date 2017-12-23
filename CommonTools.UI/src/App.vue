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
  name: "app"
};
</script>
