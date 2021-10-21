NpmJS is a folder I created to use NPM packages.
One of these is webpack.
The webpack 'build' command is fired every time you install and build this project (see the Project File):
<Target Name="PreBuild" BeforeTargets="PreBuildEvent">
	  <Exec Command="npm install" WorkingDirectory="NpmJS" />
	  <Exec Command="npm run build" WorkingDirectory="NpmJS" />
</Target>

I tried to setup SCSS/SASS, but it was getting late so I stopped at this point.
