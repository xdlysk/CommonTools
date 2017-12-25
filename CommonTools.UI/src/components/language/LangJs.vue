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

  // language
  import 'codemirror/mode/javascript/javascript.js'
  // theme css
  // require active-line.js
  import'codemirror/addon/selection/active-line.js'

import beautify from 'js-beautify';
import uglifyjs from 'uglifyjs-browser';

export default {
  name:'langjs',
  data(){
    return {
        code: 'var i=10;',
        cmOptions: {
        tabSize: 4,
        styleActiveLine: true,
        lineNumbers: true,
        line: true,
        mode: 'text/javascript',
        lineWrapping: true,
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