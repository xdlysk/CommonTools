<template>
<div>
<codemirror v-model="code" :options="cmOptions"></codemirror>
<div class="btn-group text-center">
    <button type="button" class="btn btn-primary" v-on:click="formatter">格式化</button>
    <button type="button" class="btn btn-primary" v-on:click="compress">压缩</button>
    <button type="button" class="btn btn-default">混淆</button>
</div>
</div>
  
</template>
<script>
import { codemirror } from 'vue-codemirror'
import 'codemirror/lib/codemirror.css'

import beautify from 'js-beautify';
import uglifyjs from 'uglifyjs-browser';

export default {
  name:'langjs',
  data(){
    return {
        code: 'var i =10;',
        cmOptions: {
            // codemirror options
            tabSize: 4,
            mode: 'javascript',
            theme: "base16-dark",
            lineNumbers: true,
            line: true
        }
        }
  },
  methods:{
      formatter(){
          this.code = beautify.js(this.code,{indent_size:2});
      },
      compress(){
            let ast = uglifyjs.parse(this.code);
            ast.figure_out_scope();
            let compressor = uglifyjs.Compressor();
            ast = ast.transform(compressor);
            
            ast.figure_out_scope();
            ast.compute_char_frequency();
            ast.mangle_names();
            
            this.code = ast.print_to_string();
      }
  },
  components:{
      codemirror
  }
}
</script>