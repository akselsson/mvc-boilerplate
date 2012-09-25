param (
	$watch = $false
)

$scriptPath = split-path -parent $MyInvocation.MyCommand.Definition
$root = split-path -parent $scriptPath

pushd $root
try {
	if($watch){
		bundle exec compass watch
	} else {
		bundle exec compass compile 
	}
} finally {
	popd
}