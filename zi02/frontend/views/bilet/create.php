<?php

use yii\helpers\Html;


/* @var $this yii\web\View */
/* @var $model common\models\Bilet */

$this->title = 'Create Bilet';
$this->params['breadcrumbs'][] = ['label' => 'Bilets', 'url' => ['index']];
$this->params['breadcrumbs'][] = $this->title;
?>
<div class="bilet-create">

    <h1><?= Html::encode($this->title) ?></h1>

    <?= $this->render('_form', [
        'model' => $model,
		'loty' => $loty,
		'zakupy' => $zakupy,
    ]) ?>

</div>
