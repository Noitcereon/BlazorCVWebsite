const path = require('path');

const config = {
    entry: './src/index.js',
    output: {
        path: path.resolve(__dirname, '../wwwroot/js'),
        filename: 'bundle.js'
    },
    mode: "development", // development or production
    module: {
        rules: [
            {
                test: /\.scss$/,
                use: [              // Numbers signify run order (1 being first)
                    'style-loader', // 3. Injects styles into DOM (<style>[the css]</style> in <head>)
                    'css-loader',   // 2. Turns CSS into CommonJS
                    'sass-loader'   // 1. Turns SASS into CSS.
                ]
            }
        ]
    },
    devtool: "source-map"
};

module.exports = config;