// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import router from './router'

import 'bootstrap/dist/css/bootstrap.css'

import './assets/js/jquery-vendor'

import 'bootstrap/dist/js/bootstrap.js'
import './assets/css/site.css'

import config from './config'

Vue.config.productionTip = false
Vue.use(config);

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  template: '<App/>',
  components: { App }
})
