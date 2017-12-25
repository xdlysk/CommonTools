<template>
<div>
<codemirror v-model="code" :options="cmOptions"></codemirror>

  <button class="btn btn-primary" v-on:click="formatter">格式化</button>
</div>
  
</template>
<script>
import { codemirror } from 'vue-codemirror'
import 'codemirror/lib/codemirror.css'

  // language
  import 'codemirror/mode/css/css.js'
  // require active-line.js
  import'codemirror/addon/selection/active-line.js'

import beautify from 'js-beautify';

export default {
  name:'langhtml',
  data(){
    return {
        code: '',
        cmOptions: {
          tabSize: 4,
          styleActiveLine: true,
          lineNumbers: true,
          line: true,
          mode: 'text/css'
        }
        }
  },
  methods:{
      formatter(){
          this.code = beautify.css(this.code,{indent_size:2});
      }
  },
  components:{
      codemirror
  }
}
</script>