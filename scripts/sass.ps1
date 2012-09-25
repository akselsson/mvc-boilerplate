param (
	$action = "watch"
)

$scriptPath = split-path -parent $MyInvocation.MyCommand.Definition
$root = split-path -parent $scriptPath

pushd $root
try {
	bundle install
	bundle exec compass $action
} finally {
	popd
}